import './hello-component.css';

export function helloComponent() {
  const element = document.createElement('div');
  element.innerHTML = 'Hello, WEBPACK';
  element.classList.add('hello');
  return element;
}
