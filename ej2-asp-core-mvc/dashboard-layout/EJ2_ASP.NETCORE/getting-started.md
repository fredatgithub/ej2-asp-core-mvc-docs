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

 This section briefly explains about how to render [`DashboardLayout`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayout.html) component in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part part of the system requirements and configure the common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our control.

## Add DashboardLayout to the application

You can render the DashboardLayout component in the following two ways.

* Defined the panels property as the attribute in the content template.
* Using the [`panels`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayout~Panels.html) property through tag helper.

### Setting the panels property using content template

DashboardLayout component can be rendered by using the [`ejs-dashboardlayout`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayout.html) tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DashboardLayout.

In the following sample, the dashboardlayout is rendered with [`panels`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayout~Panels.html) property using content template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/getting-started/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/getting-started/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Dashboard content template](./images/content_template.PNG)

### Setting the panels property using tag helper

You can render the DashboardLayout component by using the **panels** property through [`e-dashboardlayout-panels`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayoutPanels.html) tag helper.

In the following sample, the dashboardlayout is rendered with [`panels`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayout~Panels.html) property using tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/getting-started-panel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/getting-started-panel/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/getting-started-panel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/getting-started-panel/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Dashboard tag helper](./images/tag_helper.PNG)

> You can refer to our [ASP.NET Core Dashboard Layout](https://www.syncfusion.com/aspnet-core-ui-controls/dashboard-layout) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Dashboard Layout example](https://ej2.syncfusion.com/aspnetcore/DashboardLayout/DefaultFunctionalities#/material) to knows how to present and manipulate data.