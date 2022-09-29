import React from 'react';
import { NavLink } from 'react-router-dom';

import cls from './Lectures.module.css';

import labsIcon from '../../../../../img/lectureIcon.png';

function Lectures(){
    return(
        <NavLink to='/Lectures' className={`${cls.card} item`}>
        <div /*className={`${cls.card} item`}*/>
            <div className={`${cls.Name} cardName`}>
                <img src={labsIcon} />
                <h3>Конспекты лекций</h3>
            </div>

        </div>
    </NavLink>
    );
}

export default Lectures;