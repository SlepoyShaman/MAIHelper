import React from 'react';

import cls from './Search.module.css';

import searchIcon from "../img/searchIcon.png";

function Search() {
    return (
        <div className={cls.search}>
            <input className={cls.inputSearch} type="search" placeholder="Поиск по сайту" />
            <button className={cls.btnSearch}><img src={searchIcon} className={cls.searchIcon} /></button>
        </div>
    );
}

export default Search;