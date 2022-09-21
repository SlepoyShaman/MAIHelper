import React from 'react';

import Search from '../Search';

import cls from './Header.module.css';

function Header(props) {
    return (
        <header className={cls.header}>
            <div className="container">
                <div className={cls.offer}>
                    <h1 className={cls.title}>Учиться с нами проще</h1>
                    <p className={cls.about}>Конспекты многих лекций, готовые лабораторные работы, билеты, а также самые интересные статьи по IT-тематике и не только!</p>
                    <div className={cls.bgOffer}></div>
                </div>
                <Search />
            </div>
        </header>
    );
}

export default Header;