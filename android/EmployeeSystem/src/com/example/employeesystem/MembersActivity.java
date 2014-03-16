package com.example.employeesystem;

import helper.DBAdapter;
import android.app.Activity;
import android.content.Context;
import android.database.SQLException;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MembersActivity extends Activity {

	DBAdapter dbAdapter;
	EditText txtUserName;
	EditText txtPassword;
	Button btnLogin;
	Button btnRegister;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_member);

		txtUserName = (EditText) findViewById(R.id.txtUserName);
		txtPassword = (EditText) findViewById(R.id.txtPassword);
		btnLogin = (Button) findViewById(R.id.btnLogin);
		btnRegister = (Button) findViewById(R.id.btnRegister);

		dbAdapter = new DBAdapter(this);
		dbAdapter.open();

		btnLogin.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View arg0) {

				InputMethodManager imm = (InputMethodManager) getSystemService(Context.INPUT_METHOD_SERVICE);
				imm.hideSoftInputFromWindow(txtUserName.getWindowToken(), 0);
				imm.hideSoftInputFromWindow(txtPassword.getWindowToken(), 0);
				String username = txtUserName.getText().toString();
				String password = txtPassword.getText().toString();
				if (username.length() > 0 && password.length() > 0) {
					try {

						if (dbAdapter.Login(username, password)) {
							Toast.makeText(MembersActivity.this,
									"Successfully Logged In", Toast.LENGTH_LONG)
									.show();
						} else {
							Toast.makeText(MembersActivity.this,
									"Invalid username or password",
									Toast.LENGTH_LONG).show();
						}

					} catch (Exception e) {
						Toast.makeText(MembersActivity.this,
								"Some problem occurred", Toast.LENGTH_LONG)
								.show();

					}
				} else {
					Toast.makeText(MembersActivity.this,
							"Username or Password is empty", Toast.LENGTH_LONG)
							.show();
				}
			}
		});

		btnRegister.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				InputMethodManager imm = (InputMethodManager) getSystemService(Context.INPUT_METHOD_SERVICE);
				imm.hideSoftInputFromWindow(txtUserName.getWindowToken(), 0);
				imm.hideSoftInputFromWindow(txtPassword.getWindowToken(), 0);
				try {

					String username = txtUserName.getText().toString();
					String password = txtPassword.getText().toString();
					long i = dbAdapter.register(username, password);
					if (i != -1)
						Toast.makeText(MembersActivity.this,
								"You have successfully registered",
								Toast.LENGTH_LONG).show();

				} catch (SQLException e) {
					Toast.makeText(MembersActivity.this,
							"Some problem occurred", Toast.LENGTH_LONG).show();

				}

			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// TODO Auto-generated method stub
		return super.onCreateOptionsMenu(menu);
	}

}
