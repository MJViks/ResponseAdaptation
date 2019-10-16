import React, { Component } from 'react';
import './Home.css';
export class Home extends Component {
    displayName = Home.name
    render() {
        return (
            <div className="parallax__group">
                <div id="home-first-deep-back" className="home-first-deep-back parallax__layer parallax__layer--deep">
                 
                </div>
                <div className="parallax__layer parallax__layer--back">
                    <img className="img-logo" src="https://i.ibb.co/ngxjPCX/image.png" alt="Logo"></img>
                    <div className="text-flex">
                        <p>Lanta Group</p>
                    <h1>Заявка на адаптацию</h1>
                        </div>
                    </div>
                <div className="form-home parallax__layer parallax__layer--base">
                    <h2>Создание заявки</h2>
                    <div className="form-submit">
             
                        <input placeholder="Название организации" className="input-mini"></input>
                        <input placeholder="Название программного продукта" className="input-mini"></input>
                        <input type="email" className="input-mini"></input>
                        <textarea className="input-max"></textarea>
                        <div className="submit-block">
                            <img src="https://i.ibb.co/6mHQmxM/16-10-2019-100410.png"/>
                            <button className="input-button">Отправить</button>
                       
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
