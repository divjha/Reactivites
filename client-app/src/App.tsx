import React, { Component } from "react";
import "./App.css";
import axios from "axios";
import { Header, Icon, List } from "semantic-ui-react";

class App extends Component {
  state = {
    weatherForecast: [],
  };
  componentDidMount() {
    axios.get("http://localhost:5000/WeatherForecast").then((response) => {
      this.setState({
        weatherForecast: response.data,
      });
    });
  }
  render() {
    return (
      <div>
        <Header as="h2">
          <Icon name="users" />
          <Header.Content>Reactivities</Header.Content>
        </Header>
        <List>
          {this.state.weatherForecast.map((x: any) => (
            <List.Item key={x.id}>{x.tempC}</List.Item>
          ))}
        </List>
      </div>
    );
  }
}

export default App;
