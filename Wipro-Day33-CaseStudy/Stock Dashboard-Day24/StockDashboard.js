import React, { Component, createRef } from "react";
import io from "socket.io-client";

const socket = io("http://localhost:5000");

class StockDashboard extends Component {
  constructor() {
    super();
    this.state = {
      stockSymbol: "",
      stockPrice: 0,
      previousSearches: []
    };

    this.uncontrolledInput = createRef();
  }

  componentDidMount() {
    socket.on("stockUpdate", (price) => {
      this.setState({ stockPrice: price });
    });
  }

  componentDidUpdate(prevProps, prevState) {
    if (prevState.stockSymbol !== this.state.stockSymbol) {
      console.log("Stock symbol changed");
    }
  }

  handleChange = (e) => {
    this.setState({ stockSymbol: e.target.value });
  };

  fetchStock = () => {
    socket.emit("getStock", this.state.stockSymbol);

    this.setState({
      previousSearches: [
        ...this.state.previousSearches,
        this.uncontrolledInput.current.value
      ]
    });
  };

  render() {
    return (
      <div className="container mt-5">
        <div className="card p-4 shadow">
          <h2 className="text-center text-primary">📈 Stock Dashboard</h2>

          {/* Controlled Component */}
          <input
            type="text"
            className="form-control my-3"
            placeholder="Enter Stock Symbol"
            value={this.state.stockSymbol}
            onChange={this.handleChange}
            ref={this.uncontrolledInput}
          />

          <button
            className="btn btn-success w-100"
            onClick={this.fetchStock}
          >
            Fetch Stock
          </button>

          <h4 className="mt-4">
            Current Price: ₹ {this.state.stockPrice}
          </h4>

          <h5 className="mt-3">Previous Searches:</h5>
          <ul>
            {this.state.previousSearches.map((item, index) => (
              <li key={index}>{item}</li>
            ))}
          </ul>
        </div>
      </div>
    );
  }
}

export default StockDashboard;
