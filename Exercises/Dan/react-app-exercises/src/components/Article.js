import React, { Component } from "react";

class Article extends Component {
    render() {
        return (
            <div className="Article">
                <section className="Head">
                    <h2>{this.props.title}</h2>
                    <p>On {this.props.date}</p>
                </section>
                <section className="ArticleChildren">{this.props.children}</section>
            </div>
        );
    }
}

export default Article;

