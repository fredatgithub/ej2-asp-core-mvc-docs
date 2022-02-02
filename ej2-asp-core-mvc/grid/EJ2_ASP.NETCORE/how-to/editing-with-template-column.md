---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Editing With Template Column of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Editing With Template Column
publishingplatform: ##Platform_Name##
documentation: ug
---


# Editing with template column

You can edit the template column value by defining the **Field** for that particular column.

In the below demo, the **ShipCountry** column is rendered with the template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-temp/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-temp.cs" %}
{% include code-snippet/grid/how-to/edit-temp/edit-temp.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-temp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-temp.cs" %}
{% include code-snippet/grid/how-to/edit-temp/edit-temp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

