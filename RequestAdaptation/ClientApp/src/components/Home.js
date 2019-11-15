import React, { Component } from "react";
import "./css/Home.css";
export class Home extends Component {
    displayName = Home.name;
    constructor(props, context) {
        super(props, context);
        this.state = { loading: false };
    };


    

    

    static renderForm() {
        var Recaptcha = require('react-recaptcha');
        var verifyCallback = () => {
            document.getElementById('btnSubHome').disabled = false;
            document.getElementById('btnSubHome').onClick = Submit;
            document.getElementById('btnSubHome').style.backgroundColor = "#409fff";
        };

       var Submit = () => {
            let data = {
                name: document.getElementById('name').value,
                software: document.getElementById('softwareName').value,
                email: document.getElementById('emailText').value,
                text: document.getElementById('textArea').value
            };
            try {
                 fetch('api/Home', {
                    method: 'POST',
                    body: JSON.stringify(data),
                    headers: {
                        'Content-Type': 'application/json; charset=utf-8'
                    }
                }).then(request => request.text()).then(answ => alert(answ));

            } catch (error) {
                console.error('Ошибка:', error);
            };
        };
        return (
            <div className="form-submit">
                <p className="label">Название организации</p>
                <input id="name" className="input-mini"></input>
                <p className="label">Название программного продукта</p>
                <input id="softwareName" className="input-mini"></input>
                <p className="label">E-mail</p>
                <input id="emailText" type="email" placeholder="@" className="input-mini"></input>
                <p className="label">Текст заявки</p>
                <textarea id="textArea"
                    className="input-max"
                    placeholder="Укажите свои поженалия и предпочтения."
                ></textarea>
                <div className="submit-block">
                    <Recaptcha
                        sitekey="6LcBzb8UAAAAAGj9mYgrh59bWrbZzhdXA9oMVCm5"
                        size="normal"
                        theme="dark"
                        verifyCallback={verifyCallback}
                    />
                    <button id="btnSubHome" disabled="disabled" onClick={Submit} className="input-button">Отправить</button>
                </div>
            </div>
        );
    }

    render() {
        let form = this.state.loading ? <p><em>Loading...</em></p> : Home.renderForm();
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
                    {form}
                </div>
            </div>
        );
    }
}
