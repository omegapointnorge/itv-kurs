import './another-entry-point.css';

export function anotherEntryPointComponent() {
  const element = document.createElement('div');
  element.classList.add('footer');
  element.innerText = 'This is another entry point to the application';
  return element;
}