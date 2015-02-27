# Authorize .NET HTML Helpers

I started this project as a way to customize the
Direct Post Method (DPM) so I can use it directly in a view instead of trying to write content out from the controller like in the example in the quickstart guide provided by Authorized .NET.


## How to use:

You use it just like the Html.BeginForm and inside the brackets you can build your HTML.

	@using (Html.BeginDirectPostForm("ApiLogin", "TransactionKey", 2.25M, "https://YOUR_RELAY_RESPONSE_URL", true))
	{
	    <p>
	        <div style='float: left; width: 250px;'>
	            <label> Credit Card Number </label>
	            <div id='CreditCardNumber'>
	                <input type='text' size='28' name='x_card_num'
	                       value='4111111111111111' id='x_card_num' />
	            </div>
	        </div>
	        <div style='float: left; width: 70px;'>
	            <label>Exp.</label>
	            <div id='CreditCardExpiration'>
	                <input type='text' size='5' maxlength='5' name='x_exp_date'
	                       value='0116' id='x_exp_date' />
	            </div>
	        </div>
	        <div style='float: left; width: 70px;'>
	            <label>CCV</label>
	            <div id='CCV'>
	                <input type='text' size='5' maxlength='5' name='x_card_code' id='x_card_code'
	                       value='123' />
	            </div>
	        </div>
	    </p>
	    <div style='clear: both'></div>
	    <p>
	        <input type='submit' class='submit' value='Order with DPM!' />
	    </p>
	}

## License

This project is licensed under the Apache 2.0 license and can be found in the repository.

## Contributions

Pull requests are welcome on the development branch.