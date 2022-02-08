---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to render `Toast` component in your ASP.NET MVC application. You can
refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part
of the system requirements and configure the common specifications.

## Adding Toast control to the Application

* Now open your view page to render Toast control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/getting-started/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/getting-started/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Toast control](./images/toast.png)

## See Also

* [How to close the toast with click/tap](./how-to/close-the-toast-with-click-tap/)

* [How to prevent duplicate toast display](./how-to/prevent-duplicate-toast-display/)

* [How to show different types of toast](./how-to/show-different-types-of-toast/)