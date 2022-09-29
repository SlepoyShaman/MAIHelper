import React from 'react';
import { NavLink } from 'react-router-dom';

import cls from './Tickets.module.css';

import labsIcon from '../../../../../img/lectureIcon.png';

function Tickets(){
    return(
        <NavLink to='/Tickets' className={`${cls.card} item`}>
        <div /*className={`${cls.card} item`}*/>
            <div className={`${cls.Name} cardName`}>
                <img src={labsIcon} />
                <h3>Решенные билеты</h3>
            </div>

        </div>
    </NavLink>
    );
}

export default Tickets;