// Header.tsx
import React from 'react';

const Header: React.FC = () => {
  return (
    <header className="navbar navbar-dark bg-dark shadow-sm mb-4">
      <div className="container d-flex justify-content-center">
        <div className="text-center p-3">
          <h1 className="text-white display-5 fw-bold">Bowling League Roster</h1>
          <p className="text-info mb-0">
            Showcasing the elite bowlers of the <strong>Marlins</strong> and <strong>Sharks</strong>
          </p>
        </div>
      </div>
    </header>
  );
};

export default Header;