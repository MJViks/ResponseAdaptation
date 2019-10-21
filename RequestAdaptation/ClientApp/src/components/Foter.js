import React, { Component } from 'react';
import './css/Foter.css';
export class Foter extends Component {
    displayName = Foter.name



    render() {
        return (
            <div className="parallax__group-foter">
                <div className="foter">
                    <div className="foter-contact">
                        <h3 className="foter-h">Контакты</h3>
                        <div className="foter-contect-content">
                            <div className="foter-contect-content-text-text">
                                <p className="foter-contect-content-text">E-mail:<br />info@lanta-group.ru</p>
                                <p className="foter-contect-content-text">Телефон:<br />+7 495 649-63-39</p>
                            </div>
                            <div className="foter-contect-content-text-img">
                                <img src="https://i.ibb.co/ngxjPCX/image.png" className="foter-contect-content-logo" />
                                <img src="http://lanta-group.ru/wp-content/themes/lanta-group/image/LantaGroupQR.jpg" className="foter-contect-content-qr" />
                            </div>
                        </div>
                    </div>
                    <div className="foter-map">
                        <div className="foter-map-text">
                        <h3 className="foter-h">Адрес</h3>
                            <p className="foter-map-adres">Москва, Перова Поля 3-й пр-д, д. 8 стр. 11 Бизнес центр «Перово Поле»</p>
                        </div>
                            <div className="foter-map-content">
                            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2245.3454171843578!2d37.769643316046405!3d55.75250159948251!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x46b54b241197200d%3A0xf09d92711043d1b2!2z0JvQsNC90YLQsCDQk9GA0YPQv9C_!5e0!3m2!1sru!2sru!4v1571398785079!5m2!1sru!2sru" width="100%" height="100%" frameborder="0" ></iframe>
                        </div>
                    </div>
                   
                    <p className="foter-age-big">2019 г. Lanta-Group <br /> системная интеграция</p>
                </div>
                <p className="foter-age">2019 г. Lanta-Group <br/> системная интеграция</p>
            </div>
        );
    }
}