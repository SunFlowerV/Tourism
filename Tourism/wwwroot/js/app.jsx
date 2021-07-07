const Router = ReactRouterDOM.BrowserRouter;
const Route = ReactRouterDOM.Route;
const Switch = ReactRouterDOM.Switch;
const Link = ReactRouterDOM.Link;

class Index extends React.Component {
    render() {
        return <div>
            <Router>
                <header>
                    <div className="container">
                        <nav>
                            <Link to="/">Список стран</Link>
                            <Link to="/report">Отчёт о посещении</Link>
                        </nav>
                    </div>
                    
                </header>
                
                <Switch>
                    <Route exact path="/" render={(props) => <CountryList apiUrl="/api/index" {...props} />} />
                    <Route path="/report" render={(props) => <AttendanceReport apiUrl="/api/report" {...props} />} />
                </Switch>
                
            </Router>
        </div>;
        
    }
}
class CountryList extends React.Component {
    constructor(props) {
        super(props);
        this.state = { countrys: [] };
    }
    loadData() {
        var xhr = new XMLHttpRequest();
        xhr.open("get", this.props.apiUrl, true);
        xhr.onload = function () {
            var data = JSON.parse(xhr.responseText);
            this.setState({ countrys: data });
        }.bind(this);
        xhr.send();
    }
    componentDidMount() {
        this.loadData();
    }
    render() {
        return (<div>
            {this.state.countrys.lenght != 0 ? 
                <table>
                    <thead>
                        <tr>
                            <th>Название</th>
                            <th>Краткое описание</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.countrys.map(country =>
                            <tr key={country.id}>
                                <td>{country.name}</td>
                                <td>{country.description}</td>
                            </tr>
                        )}
                    </tbody>
                </table> :
                <p>Нет результатов</p>
                }
            
        </div>);
    }
}
class AttendanceReport extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            touristes: [],
            countryVisits: [],
            touristid: null,
            year: null,
            isLoad: false
        };
        this.onLoadTouristVisit = this.onLoadTouristVisit.bind(this);
        this.onChangeSelectTourist = this.onChangeSelectTourist.bind(this);
        this.onChangeSelectYear = this.onChangeSelectYear.bind(this);
    }
    onChangeSelectTourist(event) {
        this.setState({ touristid: event.target.value });
    }
    onChangeSelectYear(event) {
        this.setState({ year : event.target.value });
    }
    onLoadTouristVisit() {
        if (this.state.touristid != null && this.state.year != null) {
            var url = this.props.apiUrl + "/" + this.state.touristid + "/" + this.state.year;
            var xhr = new XMLHttpRequest();
            xhr.open("get", url, true);
            xhr.onload = function () {
                var data = JSON.parse(xhr.responseText);
                this.setState({ countryVisits: data });
            }.bind(this);
            xhr.send();
            this.setState({ isLoad: true });
        }
        
    }
    loadData() {
        var xhr = new XMLHttpRequest();
        xhr.open("get", this.props.apiUrl, true);
        xhr.onload = function () {
            var data = JSON.parse(xhr.responseText);
            this.setState({ touristes: data });
        }.bind(this);
        xhr.send();
    }
    componentDidMount() {
        this.loadData();
    }
    render() {
        const isLoaded = this.state.isLoad;
        return (
            <div>
                <select className="select-css" onChange={this.onChangeSelectTourist}>
                    <option value={null} ></option>
                    {this.state.touristes.map(tourist =>
                        <option value={tourist.id} > {tourist.name}</option>
                    )}

                </select>
                <select className="select-css" onChange={this.onChangeSelectYear}>
                    <option value={ null} ></option>
                    <option value="2015" > 2015</option>
                    <option value="2016" > 2016</option>
                    <option value="2017" > 2017</option>
                    <option value="2018" > 2018</option>
                    <option value="2019" > 2019</option>
                </select>
                <button className="button" onClick={this.onLoadTouristVisit}>Отчёт</button>
                {isLoaded && this.state.countryVisits.length != 0 ?
                    <table>
                        <table>
                            <thead>
                                <tr>
                                    <th>Турист</th>
                                    <th>Страна</th>
                                    <th>Дата</th>
                                </tr>
                            </thead>
                            <tbody>
                                {this.state.countryVisits.map(countryVisit =>
                                    <tr key={countryVisit.id}>
                                        <td>{countryVisit.tourist.name}</td>
                                        <td>{countryVisit.country.name}</td>
                                        <td>{countryVisit.date.substr(0, 10)}</td>
                                    </tr>
                                )}
                            </tbody>
                        </table>
                    </table>
                : <p>Нет результатов</p>}
            </div>);
        
    }
}
ReactDOM.render(
    <Index />,
    document.getElementById("content")
);