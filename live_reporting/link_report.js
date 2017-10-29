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

function makeRelativeLinks(e, i, a) {
    e = e.replace(/^(.*)[/]([^/]*)$/, '$2');
     
    return e;
}

casper.run(function () {
    liveLinks = liveLinks.map(makeRelativeLinks);
    localLinks = localLinks.map(makeRelativeLinks);

    var missingLinks = liveLinks.filter(function (e, i, a) {
        return localLinks.every(function (ee, ii, aa) {
            // is every live link missing from local links
            return ee !== e;
        });
    });

    for (var i in missingLinks) {
        console.log(missingLinks[i]);
    }

    casper.done();
}); 
