import React, { Component } from 'react';
import './css/About.css';
export class About extends Component {
    displayName = About.name
    render() {
        return (
            <div className="parallax__group">
                <div className="home-deep-back parallax__layer parallax__layer--deep_About">

                </div>
                <div className="parallax__layer parallax__layer--back">
                    <img className="img-logo" src="https://i.ibb.co/ngxjPCX/image.png" alt="Logo"></img>
                    <div className="text-flex">
                        <p>Lanta Group</p>
                        <h1 className="hd1_ab">О нас</h1>
                    </div>
                </div>
                <div className="form-home parallax__layer parallax__layer--base">
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
                            <img src="https://i.ibb.co/6mHQmxM/16-10-2019-100410.png" />
                            <button className="input-button">Отправить</button>

                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
