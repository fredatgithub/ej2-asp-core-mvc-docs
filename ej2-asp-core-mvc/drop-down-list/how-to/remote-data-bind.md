---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Remote Data Bind of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Remote Data Bind
publishingplatform: ##Platform_Name##
documentation: ug
---


# Get the total count of data when remote data bind with DropDownList

Before control rendering, you can get the total items count by using [actionComplete](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~ActionComplete.html) event with its result arguments.
After rendering this control, you can get the total items count by using `getItems` method.

The following example demonstrate how to get the total items count.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/totalcount/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Totalcount.cs" %}
{% include code-snippet/dropdownlist/how-to/totalcount/totalcount.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/totalcount/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Totalcount.cs" %}
{% include code-snippet/dropdownlist/how-to/totalcount/totalcount.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
