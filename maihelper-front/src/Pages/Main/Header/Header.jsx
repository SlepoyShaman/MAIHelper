import React from 'react';

import Search from '../../../Components/Search/Search';
import Cards from './Cards/Cards';

import cls from './Header.module.css';

function Header(props) {
    return (
        <header className={cls.header}>
            <div className="container">
                <div className={cls.headerContent}>
                    <div className={cls.offer}>
                        <h1 className={cls.title}>Учиться с нами проще</h1>
                        <p className={cls.about}>Конспекты многих лекций, готовые лабораторные работы, билеты, а также самые интересные статьи по IT-тематике и не только!</p>
                        <Search />
                        <div className={cls.bgOffer}></div>
                    </div>
                    <Cards />
                    <div className="trap"></div>
                </div>
            </div>
        </header>
    );
}

export default Header;