---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Integrate Avatar Into Listview of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Integrate Avatar Into Listview
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrate avatar into ListView

Avatar is integrated into the listview to create contacts applications. The `xsmall` size avatar is used to match
the size of the list item. Letters and images are also used as avatar content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/listview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/listview/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/listview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/listview/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Avatar ListView](../images/list.PNG)