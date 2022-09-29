import React from 'react';

import LabWorks from './LabWorks/LabWorks';
import Map from './Map/Map';
import Lectures from './Lectures/Lectures';
import Tickets from './Tickets/Tickets';
import Articles from './Articles/Articles';

import cls from './Cards.module.css';
import './Cards.css';

function Cards(props) {
    return (
        <div className={cls.cards}>
            <Map />
            <Lectures />
            <LabWorks />
            
            <Tickets />
            <Articles />
            
            
        </div>
    );
}

export default Cards;