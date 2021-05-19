# oauth.apisample.netcore

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/18e0bf7a5ae8420d989d62b287245f0a)](https://www.codacy.com/gh/gary-archer/oauth.apisample.netcore/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=gary-archer/oauth.apisample.netcore&amp;utm_campaign=Badge_Grade&x=1)

### Overview

The final API code sample using OAuth and Open Id Connect, referenced in my blog at https://authguidance.com:

- The API takes finer control over OAuth processing via a filter, implemented with a certified library
- The API also implements other [Non Functional Behaviour](https://authguidance.com/2017/10/08/corporate-code-sample-core-behavior/), to enable productivity and quality


### Details

* See the [Overview Page](http://authguidance.com/2018/01/05/net-core-code-sample-overview/) for an overview and how to run the API
* See the [OAuth Integration Page](http://authguidance.com/2018/01/06/net-core-api-key-coding-points/) for design aspects

### Programming Languages

* C# and .Net 5 are used to implement the OAuth Secured REST API

### Middleware Used

* The Kestrel web server is used to host the API over SSL, using OpenSSL self signed certificates
* AWS Cognito is used as the default Authorization Server
* The [IdentityModel Library](https://github.com/IdentityModel/IdentityModel) is used to implement the OAuth custom filter
* API logs can be aggregated to [Elastic Search](https://authguidance.com/2019/07/19/log-aggregation-setup/) to support [Query Use Cases](https://authguidance.com/2019/08/02/intelligent-api-platform-analysis/)

### SSL Certificates

* Certificates in the certs folder originate from the [OAuth Development Certificates](https://github.com/gary-archer/oauth.developmentcertificates) repository