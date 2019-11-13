import React, { Component } from "react";
import "./css/NavMenu.css";
import { NavLink } from "react-router-dom";

export class NavMenu extends Component {
    displayName = NavMenu.name;
    constructor(props) {
        super(props);
        this.state = {
            classBtn: "hamburger hamburger--spin ",
            classNav: "nav close-nav"
        };
    }

    clk = () => {
        let classNameBtn =
            this.state.classBtn === "hamburger hamburger--spin is-active"
                ? "hamburger hamburger--spin"
                : "hamburger hamburger--spin is-active";
        this.setState({ classBtn: classNameBtn });
        let classNameNav =
            this.state.classNav === "nav close-nav"
                ? "nav open-nav"
                : "nav close-nav";
        this.setState({ classNav: classNameNav });
        document.getElementById("body").style.marginLeft =
            this.state.classNav === "nav close-nav" ? "-320px" : "0px";

        document.getElementById("body").style.paddingRight =
            this.state.classNav === "nav close-nav" ? "320px" : "0px";
    };

    render() {
        return (
            <div>
                <nav className={this.state.classNav}>
                    <h3>Меню</h3>
                    <NavLink
                        onClick={this.clk}
                        exact
                        to='/'
                        className='nav-link'
                        activeClassName='ch'>
                        Заявка
					</NavLink>
                    <NavLink
                        onClick={this.clk}
                        to='/Feedback'
                        className='nav-link'
                        activeClassName='ch'>
                        Отзыв
					</NavLink>
                    <NavLink
                        onClick={this.clk}
                        to='/Contact'
                        className='nav-link'
                        activeClassName='ch'>
                        Контакты
					</NavLink>
                    <NavLink
                        onClick={this.clk}
                        to='/About'
                        className='nav-link'
                        activeClassName='ch'>
                        О нас
					</NavLink>
                </nav>

                <a onClick={this.clk} className={this.state.classBtn} type='button'>
                    <span className='hamburger-box'>
                        <span className='hamburger-inner'></span>
                    </span>
                </a>
            </div>
        );
    }
}
