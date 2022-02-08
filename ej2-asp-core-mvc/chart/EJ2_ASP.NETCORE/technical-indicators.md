---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Technical Indicators of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Technical Indicators
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Technical Indicators

A [`technical indicator`](https://www.syncfusion.com/aspnet-core-ui-controls/charts/technical-indicators) is a mathematical calculation based on historic price, volume or open interest information
that aims to forecast financial market direction.

Chart supports 10 types of technical indicators.

## Accumulation Distribution

Accumulation Distribution combines price and volume to show how money may be flowing into or out of stock.
To render a [`Accumulation Distribution Indicator`](https://ej2.syncfusion.com/aspnetcore/Chart/ADIChart#/material),
use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `AccumulationDistribution`.
To calculate the signal line [`volume`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Volume) field is additionally added with `dataSource`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/ad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ad.cs" %}
{% include code-snippet/chart/technical-indicators/ad/ad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/ad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ad.cs" %}
{% include code-snippet/chart/technical-indicators/ad/ad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Average True Range (ATR)

ATR measures the stock volatility by comparing the current value with the
previous value. To render a Average True Range (ATR) Indicator,
use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Atr`.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/atr/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Atr.cs" %}
{% include code-snippet/chart/technical-indicators/atr/atr.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/atr/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Atr.cs" %}
{% include code-snippet/chart/technical-indicators/atr/atr.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Bollinger Band

A chart overlay that shows the upper and lower limits of normal price movements based on the standard deviation of prices.
To render a Bollinger Band, use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `BollingerBand`.
Bollinger band will be represented by three lines (upperLine, lowerLine, signalLine).Bollinger Band
default values of the [`period`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Period) is 14 and
[`standardDeviations`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_StandardDeviation) is 2.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/bollinger/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bollinger.cs" %}
{% include code-snippet/chart/technical-indicators/bollinger/bollinger.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/bollinger/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bollinger.cs" %}
{% include code-snippet/chart/technical-indicators/bollinger/bollinger.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of BollingerBand**

`stroke`, `stroke-width`, and `color` of upperLine can be customized by using,[`upperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine),
and the lowerLine can be customized by using [`lowerLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_LowerLine) properties of indicator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% endhighlight %}
{% highlight c# tabtitle="code-snippet/chart/getting-started/custom-bollinger/custom-bollinger.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% endhighlight %}
{% highlight c# tabtitle="code-snippet/chart/getting-started/custom-bollinger/custom-bollinger.cs" %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Exponential Moving Average (EMA)

Moving average Indicators are used to define the direction of the trend. To render a EMA Indicator,
use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Ema`.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/ema/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ema.cs" %}
{% include code-snippet/chart/technical-indicators/ema/ema.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/ema/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ema.cs" %}
{% include code-snippet/chart/technical-indicators/ema/ema.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Momentum

Momentum shows the speed at which the price of the stock is changing. To render a Momentum indicator, use indicator
[`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Momentum`. Momentum indicator will be represented by two lines (upperLine,
signalLine).In momentum indicator the upperBand value is always render at the value 100.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/momentum/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Momentum.cs" %}
{% include code-snippet/chart/technical-indicators/momentum/momentum.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/momentum/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Momentum.cs" %}
{% include code-snippet/chart/technical-indicators/momentum/momentum.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of MomentumIndicator**

`stroke`, `stroke-width`, and `color` of upperLine can be customized by using,[`upperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine),
property of indicator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-momentum/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-momentum.cs" %}
{% include code-snippet/chart/technical-indicators/custom-momentum/custom-momentum.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-momentum/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-momentum.cs" %}
{% include code-snippet/chart/technical-indicators/custom-momentum/custom-momentum.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Moving Average Convergence Divergence (MACD)

MACD is based on the difference between two EMA's. To render a MACD Indicator, use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as
`MACD`.MACD indicator will be represented
by MACD line,signal line, MACD histogram. MACD histogram is used to differentiate MACD line and signal line.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/macd/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Macd.cs" %}
{% include code-snippet/chart/technical-indicators/macd/macd.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/macd/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Macd.cs" %}
{% include code-snippet/chart/technical-indicators/macd/macd.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of MACD**

`stroke`, `stroke-width`, and `color`of macdLine can be customized by using,[`macdLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdLine),
property of indicator. The positive and negative changes of histogram can be customized by [`macdPositiveColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdPositiveColor)
and [`macdNegativeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdNegativeColor) properties.
The [`macdType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdType) is used to define the type of
MACD indicator. To customize the MACD period using [`slowPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_SlowPeriod) and [`fastPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_FastPeriod)
properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-macd/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-macd.cs" %}
{% include code-snippet/chart/technical-indicators/custom-macd/custom-macd.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-macd/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-macd.cs" %}
{% include code-snippet/chart/technical-indicators/custom-macd/custom-macd.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Relative Strength Index (RSI)

RSI shows how strongly a stock is moving in its current direction. To render a RSI Indicator, use
indicator [`type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Rsi`.RSI indicator will be represented
by three lines (upperBand, lowerBand, signalLine). The upperBand and lowerBand values are customized by
[`overBought`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverBought)
and [`overSold`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverSold)
properties of indicator and the signalLine is calculated by RSI formula.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/rsi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rsi.cs" %}
{% include code-snippet/chart/technical-indicators/rsi/rsi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/rsi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rsi.cs" %}
{% include code-snippet/chart/technical-indicators/rsi/rsi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Simple Moving Average (SMA)

Moving average Indicators are used to define the direction of the trend. To render a SMA Indicator,
use indicator [`type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as
`Sma`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/sma/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sma.cs" %}
{% include code-snippet/chart/technical-indicators/sma/sma.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/sma/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sma.cs" %}
{% include code-snippet/chart/technical-indicators/sma/sma.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stochastic

It shows how a stock is, when compared to previous state. To render a Stochastic indicator,
use indicator [`type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Stochastic`.
stochastic indicator will be represented by four lines (upperLine, lowerLine, periodLine, signalLine).
In stochastic indicator the upperBand value and lowerBand value is customized by [`overBought`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverBought)
and [`overBought`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverBought)properties of indicators and the periodLine and
signalLine is render based on stochastic formula.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/stochastic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stochastic.cs" %}
{% include code-snippet/chart/technical-indicators/stochastic/stochastic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/stochastic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stochastic.cs" %}
{% include code-snippet/chart/technical-indicators/stochastic/stochastic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of StochasticIndicator**

`stroke`, `stroke-width`, and `color` of upperLine can be customized by using,[`upperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine),
the lowerLine can be customized by using [`lowerLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_LowerLine)
and the periodLine can be customized by using [`periodLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_PeriodLine)
properties of indicator. To customize the period to find the average price
using [`kPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_KPeriod)
and [`dPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DPeriod)
properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-stochastic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-stochastic.cs" %}
{% include code-snippet/chart/technical-indicators/custom-stochastic/custom-stochastic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-stochastic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-stochastic.cs" %}
{% include code-snippet/chart/technical-indicators/custom-stochastic/custom-stochastic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Triangular Moving Average (TMA)

Moving average indicators are used to define the direction of the trend. To render a TMA Indicator,
use indicator [`type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as
`TMA`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/tma/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tma.cs" %}
{% include code-snippet/chart/technical-indicators/tma/tma.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/tma/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tma.cs" %}
{% include code-snippet/chart/technical-indicators/tma/tma.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of Technical Indicators**

`stroke`, `stroke-width`, and `color` of signalLine can be customized by using,[`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Fill),
[`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Width)
and [`dashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DashArray)
properties and the [`period`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Period)
property is used to predict the data forecast calculations. The [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Field)
value is used to the compare the current price with previous price. It is applicable to Bollinger bands and moving
averages. The [`showZones`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_ShowZones)
property is used to shows/Hides the overBought and overSold regions. It is applicable for RSI and stochastic indicators.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-tma/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tma.cs" %}
{% include code-snippet/chart/technical-indicators/custom-tma/custom-tma.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-tma/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tma.cs" %}
{% include code-snippet/chart/technical-indicators/custom-tma/custom-tma.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Data Source**

Usually technical indicators are added along with a financial series. The [`seriesName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_SeriesName)
represents the series, the data of which has to be analysed through indicators.

Technical indicators can also be added without series using [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DataSource) property of indicator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/chart/technical-indicators/datasource/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/datasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/chart/technical-indicators/datasource/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
