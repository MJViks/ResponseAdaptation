import React, { Component } from 'react';
import './css/Feedback.css';
import { ReCaptcha } from 'react-recaptcha-google'
export class Feedback extends Component {
    displayName = Feedback.name

    constructor(props, context) {
        super(props, context);
        this.verifyCallback = this.verifyCallback.bind(this);
    }

    verifyCallback() {
        document.getElementById('btnSubFeedback').disabled = "";
        document.getElementById('btnSubFeedback').style.backgroundColor = "#409fff";
    }

    render() {
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
                        <input className="input-mini"></input>
                        <p className="label">Название программного продукта</p>
                        <input className="input-mini"></input>
                        <p className="label">E-mail</p>
                        <input type="email" placeholder="@" className="input-mini"></input>
                        <p className="label">Текст отзыва</p>
                        <textarea className="input-max" placeholder="Опишите свои впечатления после работы с нами."></textarea>
                        <div className="submit-block" >
                            <ReCaptcha
                                ref={(el) => { this.captchaDemo = el; }}
                                size="normal"
                                data-theme="dark"
                                render="explicit"
                                sitekey="6LcBzb8UAAAAAGj9mYgrh59bWrbZzhdXA9oMVCm5"
                                verifyCallback={this.verifyCallback}
                            />
                            <button id="btnSubFeedback" className="input-button" disabled="disabled">Отправить</button>

                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
