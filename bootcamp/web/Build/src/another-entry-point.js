import _ from 'lodash';
import { anotherEntryPointComponent } from './another-entry-point-component/anotherEntryPointComponent';
import './index.css';

const wrapper = document.createElement('div');
wrapper.classList.add('bundle-separator');
const header = document.createElement('h1');
header.textContent = 'THIS IS ANOTHER-ENTRY-POINT.JS';

wrapper.appendChild(header);
wrapper.appendChild(anotherEntryPointComponent());
document.body.appendChild(wrapper);

console.log(_.join(['Another', 'module', 'loaded!'], ' '));
