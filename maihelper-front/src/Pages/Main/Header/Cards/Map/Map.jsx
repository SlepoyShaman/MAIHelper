import React from 'react';
import { NavLink } from 'react-router-dom';

import cls from './Map.module.css';
import MapIcon from '../../../../../img/mapIcon.png';

function Map() {
    return(
        <NavLink to='/Map' className={`${cls.card} item`}>
            <div /*className={`${cls.card} item`}*/>
                <div className={`${cls.Name} cardName`}>
                    <img src={MapIcon} />
                    <h3>Карта</h3>
                </div>
            </div>
        </NavLink>
    );
}

export default Map;