---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Search On Filtering of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Search On Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Limit the search result on filtering

The following example demonstrates about how to set limit the search result on filtering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/limitsearch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Limitsearch.cs" %}
{% include code-snippet/dropdownlist/how-to/limitsearch/limitsearch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/limitsearch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Limitsearch.cs" %}
{% include code-snippet/dropdownlist/how-to/limitsearch/limitsearch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
