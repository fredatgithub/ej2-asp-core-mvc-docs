---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Group Header of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Group Header
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable the Fixed group header in DropDownList

The following example demonstrate about how to disable the Fixed group header in DropDownList through CSS by using `visibility` attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/disbalefixedheader/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/how-to/disbalefixedheader/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/disbalefixedheader/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/how-to/disbalefixedheader/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
