import logo from "./logo.svg";
import "./App.css";
import React, {Component} from "react"

function App() {
    const name = "Björn's Website";
    const today = new Date().toLocaleDateString();

    return (
        <div className="App">
            <header className="App-header" style={{display: "flex", flexDirection: "row"}}>
                <img src={logo} className="App-logo" alt="logo" />
                <h1>Welcome to {name}!</h1>
            </header>
            <p>Today is {today}</p>
            <StopWatch/>
            <ClickCounter />
            <Article date={today} title="Learning React">
              <ul>
                <li>Understanding Components</li>
                <li>Understanding Props</li>
              </ul>
            </Article>
            <Article date={today} title="Learning JSX">
            <p>It's translate to regular JavaScript.</p>
            </Article>
            <Article date={today} title={"Building " + name}>
            <ol>
                <li>create-react-app</li>
                <li>Understanding Props</li>
                <li>Create my first functional Component</li>
                <li>Adding Props</li>
                <li>Adding Children</li>
              </ol>
            </Article>
            <Article date="8/25/2020" title="Learning JavaScript">
              <p>What is JavaScript?</p>
              <StopWatch/>
            </Article>
            <Article date="8/14/2020" title="Learning CSS" ><p>What is CSS?</p>
            </Article>
            <Article date="8/13/2020" title="Learning HTML" ><p>What is HTML?</p>
            </Article>
        </div>
    );
}

class Article extends Component {
  constructor(props) {
    super(props);

    this.state = {
      showChildren: false
    }
  }

  render() {
    const onTitleClickHandler = () => {
      this.setState({
        showChildren: !this.state.showChildren
      });
    }

      return (
          <div className="Article">
              <section className="Head">
                  <h2 onClick={onTitleClickHandler}>{this.props.title}</h2>
                  <p>On {this.props.date}</p>
              </section>
              <section className="ArticleChildren">
                  {this.state.showChildren && this.props.children}        
                  </section>      
          </div>
      );
  }
}

class ClickCounter extends Component {  
  constructor(props) {
    super(props);

    this.state = {
      counter: 0
    }
  }

  render() {

    const clickHandler = () => {
      this.setState({
        counter: this.state.counter + 1,
      });
    }

    console.log("Rendering...")
    return <div>
      <button onClick={clickHandler}>
        Click me!
      </button>
      <p>You have clicked {this.state.counter} times.</p> 
    </div>
  }
}

class StopWatch extends Component {
  constructor(props) {
    super(props)
    this.state = {
      mountTime: new Date().getTime(),
      currentTime: new Date().getTime()
    }
  }

  componentDidMount() {
    this.intervalHandle = setInterval(()=> {
      this.setState({
        currentTime: new Date().getTime()
      })
    })
  }

  componentWillUnmount() {
    clearInterval(this.intervalHandle)
  }

  render() {
    const seconds = (this.state.currentTime - this.state.mountTime) / 1000
    return (
      <p>
        I've been mounted for <strong>{seconds.toFixed(1)}</strong> seconds.
      </p>
    )
  }
}

export default App;


