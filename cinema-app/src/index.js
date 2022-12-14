import React from 'react';
import ReactDOM from 'react-dom/client';
import classes from './index.css';
import App from './App';
import { BrowserRouter } from 'react-router-dom';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
    <BrowserRouter>
      <App className={classes.wrapper}/>
    </BrowserRouter>
);

