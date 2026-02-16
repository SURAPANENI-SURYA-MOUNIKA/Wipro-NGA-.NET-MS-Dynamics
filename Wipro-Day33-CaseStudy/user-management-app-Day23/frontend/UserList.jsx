import React from "react";
import axios from "axios";

class UserList extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      users: []
    };
  }

  componentDidMount() {
    this.fetchUsers();
  }

  componentDidUpdate(prevProps) {
    if (prevProps.refresh !== this.props.refresh) {
      this.fetchUsers();
    }
  }

  fetchUsers = () => {
    axios.get("http://localhost:5000/users")
      .then(res => this.setState({ users: res.data }));
  }

  render() {
    return (
      <div>
        <h2>User List</h2>
        {this.state.users.map(user => (
          <p key={user.id}>{user.name}</p>
        ))}
      </div>
    );
  }
}

export default UserList;
