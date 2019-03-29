Glass.Mapper
============

Glass.Mapper has been the redevelopment of the very popular Glass.Sitecore.Mapper project. This project aims to create a more robust and more flexible solution that not only works with many different CMS's.

A key feature of the implementation is the introduction of pipelines for most of the tasks carried out by Glass.Mapper allowing you to swap in your preferred solution, for example if you don't like the standard way to create a concrete object then you can implement you own and swap it in.

Development Setup
=================

Copy Sitecore complete bin folder for respective versions into `\Depends\Sitecore\bin{version}`

Copy `license.xml` to FakeDb projects:

- \Tests\Unit Tests\Glass.Mapper.Sc.FakeDb
- \Tests\Unit Tests\Glass.Mapper.Sc.FakeDb.ThirdParty
- \Tests\Unit Tests\Glass.Mapper.Sc.Legacy.FakeDb
- \Tests\Unit Tests\Glass.Mapper.Sc.WebForms.FakeDb