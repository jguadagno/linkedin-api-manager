# Developers Getting Started Guide

This document will cover what you need on your development machine to get started with the project. 
As well as how to setup the project for development.

## Required Software

* Visual Studio, Visual Studio Code, JetBrain Rider, or another IDE

## Setup

### Secrets

In order for the LinkedIn.Tests to work, you'll need to add a secret to your user secrets file for the `LinkedIn.Tests`

```json
{
  "LinkedIn:ClientId": "",
  "LinkedIn:ClientSecret": "",
  "LinkedIn:AccessToken": "",
  "LinkedIn:AuthorId": ""
}
```

***Note***: Only the `AccessToken` and `AuthorId` are required for the tests to work.

Plus, if you want to use the [LinkedIn.http](./LinkedIn.http) file to test the calls to the LinkedIn Api, 
you'll need to generate a `linkedin.private.env.json` file that looks like this

```json
{
  "linkedin-dev": {
    "client-id": "",
    "client-secret": "",
    "my-access-token": "",
    "refresh-token": "",
    "my-person-id": ""
  }
}
```
The `my-access-token` is the secret that is needed for the *LinkedIn.Test* project `LinkedIn:AccessToken` secret..
