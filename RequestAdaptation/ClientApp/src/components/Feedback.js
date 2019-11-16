import React, { Component } from 'react';
import './css/Feedback.css';
import { ReCaptcha } from 'react-recaptcha-google'
export class Feedback extends Component {
    displayName = Feedback.name

    constructor(props) {
        super(props);
        this.state = {
            capch: false,
        };
    };

    Submit = () => {
        if (this.state.capch) {
            const data = {
                name: document.getElementById('name').value,
                software: document.getElementById('software').value,
                email: document.getElementById('email').value,
                text: document.getElementById('text').value
            };
            try {
                fetch('api/Feedback', {
                    method: 'POST',
                    body: JSON.stringify(data),
                    headers: {
                        'Content-Type': 'application/json; charset=utf-8'
                    }
                }).then(request => request.text()).
                    then(answ => alert(answ));
                alert(this.state.data.email);

            } catch (error) {
                console.error('Ошибка:', error);
            };
        }
    };

    render() {
        var Recaptcha = require('react-recaptcha');
        var verifyCallback = () => {
            this.setState({ capch: true });
            document.getElementById('btnSubFeedback').style.backgroundColor = "#409fff";
        };
        return (

            <div className="parallax__group">
                <div className="home-deep-back parallax__layer parallax__layer--deep_Feedback">

                </div>
                <div className="parallax__layer parallax__layer--back">
                    <img className="img-logo" src="https://i.ibb.co/ngxjPCX/image.png" alt="Logo"></img>
                    <div className="text-flex">
                        <p>Lanta Group</p>
                        <h1 className="hd1">Отзывы</h1>
                    </div>
                </div>
                <div className="form-feedback parallax__layer parallax__layer--base">
                    <h2>Создание отзыва</h2>
                    <div className="form-submit">
                        <p className="label">Название организации</p>
                        <input id="name" className="input-mini"></input>
                        <p className="label">Название программного продукта</p>
                        <input id="software" className="input-mini"></input>
                        <p className="label">E-mail</p>
                        <input id="email" type="email" placeholder="@" className="input-mini"></input>
                        <p className="label">Текст отзыва</p>
                        <textarea id="text" className="input-max" placeholder="Опишите свои впечатления после работы с нами."></textarea>
                        <div className="submit-block" >
                            <Recaptcha
                                sitekey="6LcBzb8UAAAAAGj9mYgrh59bWrbZzhdXA9oMVCm5"
                                theme="dark"
                                verifyCallback={verifyCallback}
                                expiredCallback={verifyCallback}
                            />
                            <button id="btnSubFeedback" onClick={this.Submit} className="input-button">Отправить</button>

                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
