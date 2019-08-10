import { imgComponent } from './imgComponent/imgComponent';
import { helloComponent } from './helloComponent/helloComponent';
import './index.css';
import _ from 'lodash';

const wrapper = document.createElement('div');
wrapper.classList.add('bundle-separator');
const header = document.createElement('h1');
header.textContent = 'THIS IS INDEX.JS';

wrapper.appendChild(header);
wrapper.appendChild(helloComponent());
wrapper.appendChild(imgComponent());
document.body.appendChild(wrapper);

console.log(_.join(['Index', 'module', 'loaded!'], ' '));
