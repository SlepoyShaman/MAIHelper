import React from 'react';
import cls from './Nav.module.css';

import userIcon from "../img/userIcon.png";

import Logo from './Logo';

function Nav() {
    return (
        <nav className = {cls.nav}>
            <div className = {cls.container}>
                <Logo logoImgUrl = "../img/logo.png"/>

                <ul className={cls.navList}>
                    <li className={cls.item}>Институт</li>
                    <li className={cls.item}>Статьи</li>
                    <li className={cls.item}>Наша команда</li>
                </ul>

                <div className={cls.btnLogin}>
                    <img src={userIcon} className={cls.userIcon} />
                    <p>Войти</p>
                </div>
            </div>
        </nav>
    );
}

export default Nav;
