import React from 'react';
import { NavLink } from 'react-router-dom';

import cls from './Articles.module.css';

import labsIcon from '../../../../../img/labsIcon.png';

function Articles(props) {
    return (
        <NavLink to='/Articles' className={`${cls.card} item`}>
            <div /*className={`${cls.card} item`}*/>
                <div className={cls.Name}>
                    <h3>Статьи</h3>
                </div>

            </div>
        </NavLink>
    );
}

export default Articles;