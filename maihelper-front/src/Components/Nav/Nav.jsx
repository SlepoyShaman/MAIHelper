import React from 'react';
import cls from './Nav.module.css';

import userIcon from "../../img/userIcon.png";

import Logo from '../Logo/Logo';
import { NavLink } from 'react-router-dom';

function Nav() {
    return (
        <nav className = {cls.nav}>
            <div className = {cls.container}>
                <NavLink to="/"><Logo logoImgUrl = "../img/logo.png"/></NavLink>

                <ul className={cls.navList}>
                    <li className={cls.item}><NavLink to="/">Институт</NavLink></li>
                    <li className={cls.item}><NavLink to="/">Статьи</NavLink></li>
                    <li className={cls.item}><NavLink to="/">Наша команда</NavLink></li>
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
