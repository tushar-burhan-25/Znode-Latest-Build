var jurl = function (e) {
    function r(e) {
        return e === null || typeof e === "undefined" || i(e) === ""
    }

    function i(e) {
        if (e === null || typeof e === "undefined") {
            return e
        }
        e = e + "";
        return e.replace(/(^\s*)|(\s*$)/g, "")
    }

    function s(e) {
        var t = /^((((file|gopher|news|nntp|telnet|http|ftp|https|ftps|sftp):\/\/)?(www\.)?([a-zA-Z0-9\-\.]+(\.[a-zA-Z]{2,3})?(:[a-zA-Z0-9]*)?))(\/[a-zA-Z0-9\-_\/]*)?)(\?([a-zA-Z0-9\-_&=%]*))?(#([a-zA-Z0-9\-_&=\/]*))?$/;
        var n = t.exec(e);
        if (n < 3) {
            return ""
        }
        return {
            base: n[2],
            urlParameters: u(n[9]),
            queryParameters: o(n[11]),
            hashParameter: n[13]
        }
    }

    function o(e) {
        if (r(e)) {
            return {}
        }
        var t = {};
        var n = e.split("&");
        var i;
        for (i = 0; i < n.length; i += 1) {
            var s = n[i].split("=");
            t[s[0]] = "";
            if (s.length > 1) {
                t[s[0]] = s[1]
            }
        }
        return t
    }

    function u(e) {
        if (r(e)) {
            return []
        }
        var t = [];
        var n = e.split("/");
        var i;
        for (i = 0; i < n.length; i += 1) {
            if (!r(n[i])) {
                t.push(n[i])
            }
        }
        return t
    }
    var t = this;
    var n = s(e);
    t.addUrlParameter = function (e, s) {
        e = i(e);
        if (!r(e)) {
            if (r(s) && isNaN(s)) {
                n.urlParameters.push(e)
            } else {
                if (s < n.urlParameters.length) {
                    n.urlParameters.splice(s, 0, e)
                }
            }
        }
        return t
    };
    t.setQueryParameter = function (e, s) {
        e = i(e);
        if (!r(e)) {
            n.queryParameters[e] = "";
            if (!r(s)) {
                n.queryParameters[e] = s
            }
        }
        return t
    };
    t.setHashParameter = function (e) {
        e = i(e);
        if (r(e)) {
            n.hashParameter = null
        }
        n.hashParameter = i(e);
        return t
    };
    t.getQueryParameter = function (e) {
        e = i(e);
        if (r(e) || !n.queryParameters.hasOwnProperty(e)) {
            return null
        }
        return n.queryParameters[e]
    };
    t.getParameterIndex = function (e) {
        e = i(e);
        var t;
        for (t = 0; t < n.urlParameters.length; t += 1) {
            if (n.urlParameters[t] === e) {
                return t
            }
        }
        return null
    };
    t.getHost = function (e) {
        return n.base
    };
    t.removeUrlParameter = function (e) {
        e = i(e);
        if (n.urlParameters.indexOf(e) > -1) {
            n.urlParameters.splice(n.urlParameters.indexOf(e), 1)
        }
        return t
    };
    t.removeQueryParameter = function (e) {
        e = i(e);
        if (n.queryParameters.hasOwnProperty(e)) {
            delete n.queryParameters[e]
        }
        return t
    };
    t.build = function () {
        var e = n.base;
        if (n.urlParameters.length > 0) {
            e += "/" + n.urlParameters.join("/")
        }
        var t = [],
            i;
        for (i in n.queryParameters) {
            if (n.queryParameters.hasOwnProperty(i)) {
                var s = i;
                var o = n.queryParameters[i];
                if (!r(o)) {
                    s += "=" + o
                }
                t.push(s)
            }
        }
        if (t.length > 0) {
            e += "?" + t.join("&")
        }
        if (!r(n.hashParameter)) {
            e += "#" + n.hashParameter
        }
        return e
    };
    return t
};
(function (e) {
    e.fn.jurl = function () {
        if (this.attr("href")) {
            return new jurl(this.attr("href"))
        }
        throw "Not href attribute on element: " + input
    }
})(jQuery)