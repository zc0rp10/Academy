import React, {useState} from 'react'
import './App.css'

function App () {
  const headingText = 'Academy React News Bulletin'
  const today = new Date().toLocaleDateString()

  return (
    <div className='App'>
            
      <header className='App-header'>
        <h1>{headingText}</h1>
        <p>Today is {today}</p>
      </header>

      <News
        title='React is the best!'
        preamble='Lorem ipsum dolor...'
        date={today}
      />

      <News title='News with children' date='2020-03-01'>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
        <p>
          Vestibulum pretium sapien sit amet dui feugiat, nec tempus leo
          aliquam.
        </p>
        <p>Donec mattis lorem nec ante maximus, nec suscipit lacus rutrum.</p>
      </News>

    </div>
  )
}

// ---------------------------------
// CHECKPOINT
// ---------------------------------

function News({title, date, children}) {
  const [showChildren, setShowChildren] = useState({
    show: false,
    numberOfDisplays: 0
  });

  const titleClickHandler = () => {
    const increment = (showChildren.show == false) ? 1 : 0;

    setShowChildren(prevState => ({
      show: !prevState.show,
      numberOfDisplays: prevState.numberOfDisplays + increment
    }));
  }

  return (
    <article className="News">
      <h1 onClick={titleClickHandler}>{title}</h1>
      <em>{date}</em>
      <strong>Views: {showChildren.numberOfDisplays}</strong>
      <div className="NewsChildren">
      {showChildren.show && children}
      </div>
    </article>
  )
}


export default App
