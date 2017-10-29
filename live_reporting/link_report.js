var casper = require('casper').create();
var localLinks;
var liveLinks;

function getLinks() {
    // Scrape the liveLinks from top-right nav of the website
    var liveLinks = document.querySelectorAll('a');

    return Array.prototype.map.call(liveLinks, function (e) {
        return e.getAttribute('href')
    });
}

// Opens David D. Friedman homepage
casper.start('http://daviddfriedman.com/');

casper.then(function () {
    liveLinks = this.evaluate(getLinks);
});

casper.thenOpen('http://localhost:5000/', function () {
    this.echo("Reviewing localhost");
});

casper.then(function () {
    localLinks = this.evaluate(getLinks);
});

casper.run(function () {
    var missingLinks = liveLinks.filter(function (e, i, a) {
        return localLinks.some(function (ee, ii, aa) {
            return ee === e;
        }) === false;
    });

    for (var i in missingLinks) {
        console.log(missingLinks[i]);
    }

    casper.done();
}); 
