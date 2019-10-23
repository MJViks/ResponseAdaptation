import React, { Component } from "react";
import { NavMenu } from "./NavMenu";
import { Foter } from "./Foter";
import "./css/Layout.css";

export class Layout extends Component {
    displayName = Layout.name;
    backHide = () => {
        let st = document.getElementById("layout").scrollTop,
            sb =
                document.getElementById("layout").scrollTop +
                document.body.clientHeight,
            HFDB = document.getElementsByClassName("home-deep-back");
        for (let i = 0; i < HFDB.length; i++) {
            let dotOfEnd = HFDB[i].getBoundingClientRect().x + HFDB[i].offsetHeight,
                dotOfStart = HFDB[i].getBoundingClientRect().x;
            if (st > dotOfEnd || sb < dotOfStart) HFDB[i].style.visibility = "hidden";
            else HFDB[i].style.visibility = "";
        }
    };

    render() {
        return (
            <div>
                <div onScroll={this.backHide} id="layout" className="parallax">
                    {this.props.children}
                    <Foter />
                </div>
                <NavMenu />
            </div>
        );
    }
}
