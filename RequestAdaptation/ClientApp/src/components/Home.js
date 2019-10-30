import React, { Component } from "react";
import "./css/Home.css";
export class Home extends Component {
    displayName = Home.name;
    render() {
        return (
            <div className="parallax__group">
                <div className="home-deep-back parallax__layer parallax__layer--deep_Home"></div>
                <div className="parallax__layer parallax__layer--back">
                    <img
                        className="img-logo"
                        src="https://i.ibb.co/ngxjPCX/image.png"
                        alt="Logo"
                    ></img>
                    <div className="text-flex">
                        <p>Lanta Group</p>
                        <h1 className="hd1">Заявка на адаптацию</h1>
                    </div>
                </div>
                <div className="form-home parallax__layer parallax__layer--base">
                    <h2>Создание заявки</h2>
                    <div className="form-submit">
                        <p className="label">Название организации</p>
                        <input className="input-mini"></input>
                        <p className="label">Название программного продукта</p>
                        <input className="input-mini"></input>
                        <p className="label">E-mail</p>
                        <input type="email" placeholder="@" className="input-mini"></input>
                        <p className="label">Текст заявки</p>
                        <textarea
                            className="input-max"
                            placeholder="Укажите свои поженалия и предпочтения."
                        ></textarea>
                        <div className="submit-block">
                            <div className="g-recaptcha " data-sitekey="6LcBzb8UAAAAAGj9mYgrh59bWrbZzhdXA9oMVCm5"></div>
                            <button className="input-button">Отправить</button>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
