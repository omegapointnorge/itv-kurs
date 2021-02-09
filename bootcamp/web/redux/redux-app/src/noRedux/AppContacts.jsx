import React, { useState } from "react";

export const AppContacts = () => {
  const [contacts, setContacts] = useState([]);

  return (
    <>
      <AppHeader title="Contacts" ingress={`Say hello to anyone of your ${contacts.length} contacts`} />
      <AppContactsLists
        contacts={contacts}
        onContactAdd={(contact) => setContacts([...contacts, contact])}
      ></AppContactsLists>
    </>
  );
};

export const AppContactsLists = ({ contacts, onContactAdd }) => {
  const saveContact = () => {
    const newContact = {};
    // ... Logic for saving contact
    onContactAdd(newContact);
  };
  return (
    <>
      {contacts.map((contact) => (
        <div key={contact.id}> {contact.name}</div>
      ))}
      <button onClick={saveContact}>Save contact</button>;
    </>
  );
};

export const AppHeader = ({ title, ingress }) => {
  return (
    <>
      <h1> {title}</h1>
      <h4> {ingress}</h4>
    </>
  );
};
