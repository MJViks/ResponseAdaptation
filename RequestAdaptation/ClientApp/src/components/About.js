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
                <div className="form-about parallax__layer parallax__layer--base">
                    <img className="about-img" src="https://i.ibb.co/sqhxnsS/about-img.png" alt="about-img"/>
                    <p className="about-text">Компания LantaGroup является молодой, динамично развивающейся компанией,
                        специализирующейся в области системной интеграции. Объединив
                        высококвалифицированных специалистов, обладающих глубокими знаниями и
                        многолетним опытом реализации проектов в области информационных
                        технологий, Компания LantaGroup предоставляет комплекс услуг
                        системной интеграции, необходимых при создания IТ-инфраструктуры
                        для компаний любого масштаба.
                    </p>
                    <p className="about-text">
                        Основными направлениями деятельности компании являются: системная
                        интеграция,
                        внедрение инфраструктурных решений, проектирование и создание
                        корпоративных сетей и инженерных систем; аутсорсинг технической
                        поддержки ИТ-инфраструктуры; решения в области центров обработки
                        данных, систем хранения и вычислительных комплексов.
                    </p>
                </div>
            </div>
        );
    }
}
