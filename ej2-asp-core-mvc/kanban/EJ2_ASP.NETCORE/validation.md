---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Validation of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Validation

Validate particular column using the `minCount` or `maxCount` properties. The corresponding columns gets different appearance when validation fails. In default layout, `constraintType` property accept only `column` type. In swimlane layout, accept both `column` and `swimlane` constraint type.

There are two types of constraints:
1. Column
2. Swimlane

> By default, the column count validation is performed based on Kanban **Columns**.

## Minimum card limit

The `minCount` property is used to specify the minimum cards hold on particular column or swimlane cell. If the column or swimlane total card count falls short of the minimum count value, it shows the column or cell background colour with validation fails.

## Maximum card limit

The `maxCount` property is used to specify the maximum cards hold on particular column or swimlane cell. If the column or swimlane cell total card count exceeds the maximum count value, it shows the column or cell background colour with validation fails.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/validation/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/validation/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/validation.PNG)