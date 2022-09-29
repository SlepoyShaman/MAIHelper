import React from 'react';
import { NavLink } from 'react-router-dom';

import cls from './LabWorks.module.css';

import labsIcon from '../../../../../img/labsIcon.png';

function LabWorks(props) {
    return (
        <NavLink to='/Labs' className={`${cls.card} item`}>
            <div /*className={`${cls.card} item`}*/>
                <div className={`${cls.Name} cardName`}>
                    <img src={labsIcon} />
                    <h3>Лабораторные работы</h3>
                </div>

            </div>
        </NavLink>
    );
}

export default LabWorks;