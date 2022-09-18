import React from 'react';

import cls from './Logo.module.css';

function Logo(props) {
    return (
        <div className={cls.logo}>
            <img src={props.logoImgUrl} />
            <p><span>MAI </span> Helper</p>
        </div>
    );
}

export default Logo;
