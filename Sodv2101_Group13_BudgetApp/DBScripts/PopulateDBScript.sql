
USE Sodv2101_BudgetAppDB
GO


INSERT INTO IncomeType (Type) VALUES
('Salary'),
('Hourly');

/*
('Freelance'),
('Rental Income'),
('Investment Returns'),
('Side Hustle'),
('Government Benefits'),
('Other') ;
*/




INSERT INTO Users (FirstName, LastName, Email, Password) VALUES
('Alex', 'Fincher', 'alex.fincher@example.com', 'Pass1234'),
('Taylor', 'Rivers', 'taylor.rivers@example.com', 'SecurePass!'),
('Jordan', 'Harper', 'jordan.harper@example.com', 'BudgetMaster2024'),
('Charlie', 'Dale', 'charlie.dale@example.com', 'SavingsPro2024'),
('Sam', 'Rowe', 'sam.rowe@example.com', 'FinanceGuru2024');




INSERT INTO Income (Amount, TimePeriod, IncomeTypeID, UserID) VALUES
(4000.00, 'Monthly', 1, 1), -- Alex, Salary
(1500.00, 'Weekly', 2, 2), -- Taylor, Hourly
(2500.00, 'Monthly', 2, 3), -- Jordan, Hourly
(200.00, 'Quarterly', 2, 4), -- Charlie, Salary
(300.00, 'Weekly', 1, 5); -- Sam, Hourly 

INSERT INTO HoursWorked ([Hours], Date, IncomeID) VALUES
(40.00, '2024-11-13', 2),
(35.50, '2024-11-14', 3),
(20.25, '2024-11-15', 2),
(25.00, '2024-11-16', 5),
(15.75, '2024-11-17', 3);

INSERT INTO Budget (BudgetName, MaxAmount, Description, UserID) VALUES
('Monthly Essentials', 2000.00, 'Rent, groceries, utilities, etc.', 1), -- Alex
('Freelance Expenses', 500.00, 'Tools and services for projects', 2), -- Taylor
('Property Maintenance', 1500.00, 'Repairs and upkeep for rental property', 3), -- Jordan
('Investment Tracking', 300.00, 'Money for reinvestment opportunities', 4), -- Charlie
('Savings Goals', 1000.00, 'Emergency fund and long-term savings', 5); -- Sam


INSERT INTO FinancialGoal (Amount, Description, Deadline, UserID) VALUES
(10000.00, 'Buy a new car', '2025-06-30', 1), -- Alex
(5000.00, 'Pay off student loans', '2025-01-15', 2), -- Taylor
(15000.00, 'Invest in a second property', '2025-12-31', 3), -- Jordan
(2000.00, 'Save for a vacation', '2025-03-15', 4), -- Charlie
(3000.00, 'Build an emergency fund', '2025-09-01', 5); -- Sam

INSERT INTO Contribution (GoalID, Amount, Description) VALUES
(1, 2000.00, 'Saved from salary'), -- Alex
(2, 1000.00, 'Paid extra from freelance gig'), -- Taylor
(3, 5000.00, 'Initial savings for property'), -- Jordan
(4, 500.00, 'Set aside from investments'), -- Charlie
(5, 1000.00, 'First emergency fund deposit'); -- Sam



INSERT INTO Expense(BudgetID, Amount, Description, PurchaseDate) VALUES 
(1, 15.00, 'Morning Coffee', '2024-11-01'),
(1, 50.00, 'Groceries - Weekly Shop', '2024-11-02'),
(2, 150.00, 'Concert Tickets', '2024-11-03'),
(3, 200.00, 'Monthly Gym Membership', '2024-11-04'),
(2, 30.00, 'Gas for Car', '2024-11-05'),
(4, 1200.00, 'Monthly Rent', '2024-11-01'),
(4, 60.00, 'Utilities - Electricity Bill', '2024-11-03'),
(5, 25.00, 'Birthday Gift for Friend', '2024-11-06'),
(1, 8.00, 'Lunch at Work', '2024-11-07'),
(5, 10.00, 'Streaming Service Subscription', '2024-11-08');



