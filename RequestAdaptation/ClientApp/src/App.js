import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";
import { FetchData } from "./components/FetchData";
import { About } from "./components/About";
import { Feedback } from "./components/Feedback";


export default class App extends Component {
    displayName = App.name;
    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route exact path='/Feedback' component={Feedback} />
                <Route path='/fetchdata' component={FetchData} />
                <Route exact path='/About' component={About} />
            </Layout>
        );
    }
}
