// App.tsx
import './App.css'
import Header from './Header' // 1. Import the new header
import BowlerList from './BowlerList'

function App() {
  return (
    <>
      <Header />      {/* 2. Add the component here */}
      <div className="container"> 
        <BowlerList />
      </div>
    </>
  )
}

export default App
