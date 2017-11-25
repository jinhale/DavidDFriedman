var casper = require('casper').create();
var localLinks;
var liveLinks;
var localAcademicLinks;
var liveAcademicLinks;

function getLinks() {
    // Scrape the liveLinks from top-right nav of the website
    var liveLinks = document.querySelectorAll('a');

    return Array.prototype.map.call(liveLinks, function (e) {
        return e.getAttribute('href')
    });
}

function filterMatchedLinks(liveList, localList) {
    var prefixRexEx = /[^/]*[/]/g;
    
    return liveList.filter(function (e, i, a) {
        e = e.replace(prefixRexEx, '');

        // Filter links to fragment identifiers
        // of the same page. 
        if (/^#[a-z]*$/i.test(e)) { return false; }
        if (/^index.shtml#[a-z]*$/i.test(e)) { return false; }

        // Return unmatched (some === false) links.
        return localList.some(function (ee, ii, aa) {
            ee = ee.replace(prefixRexEx, '');

            return ee === e;
        }) === false;
    });    
}

// Opens David D. Friedman homepage
casper.start('http://daviddfriedman.com/');

casper.then(function () {
    liveLinks = this.evaluate(getLinks);
});

casper.thenOpen('http://localhost:5000/', function () {
    this.echo("---- BEGIN REPORT - MISSING LINKS");
});

casper.then(function () {
    localLinks = this.evaluate(getLinks);
});

casper.run(function () {
    var missingLinks = filterMatchedLinks(liveLinks, localLinks);
    
    for (var i in missingLinks) {
        console.log(missingLinks[i]);
    }

    this.echo('---- END REPORT - MISSING HOMEPAGE LINKS \n');

    this.echo('---- BEGIN REPORT - MISSING ACADEMIC LINKS');

    

    this.echo('---- END REPORT - MISSING ACADEMIC LINKS \n').exit();
}); 
