// ------------------------------------------------------------------------------
// -- Copyright ERTMS Solutions
// -- Licensed under the EUPL V.1.1
// -- http://joinup.ec.europa.eu/software/page/eupl/licence-eupl
// --
// -- This file is part of ERTMSFormalSpec software and documentation
// --
// --  ERTMSFormalSpec is free software: you can redistribute it and/or modify
// --  it under the terms of the EUPL General Public License, v.1.1
// --
// -- ERTMSFormalSpec is distributed in the hope that it will be useful,
// -- but WITHOUT ANY WARRANTY; without even the implied warranty of
// -- MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// --
// ------------------------------------------------------------------------------

namespace DataDictionary.Tests
{
    public class Expectation : Generated.Expectation, IExpressionable, TextualExplain
    {
        public override string ExpressionText
        {
            get
            {
                string retVal = Value;
                if (retVal == null)
                {
                    retVal = "";
                }
                return retVal;
            }
            set { Value = value; }
        }

        /// <summary>
        /// The enclosing step, if any
        /// </summary>
        public Step Step
        {
            get { return SubStep.Step; }
        }

        /// <summary>
        /// The enclosing sub-step, if any
        /// </summary>
        public SubStep SubStep
        {
            get { return Enclosing as SubStep; }
        }

        /// <summary>
        /// The enclosing translation, if any
        /// </summary>
        public Translations.Translation Translation
        {
            get { return Enclosing as Translations.Translation; }
        }

        /// <summary>
        /// The enclosing frame
        /// </summary>
        public Frame Frame
        {
            get { return Utils.EnclosingFinder<Tests.Frame>.find(this); }
        }

        /// <summary>
        /// The expected value
        /// </summary>
        public string Value
        {
            get { return getValue(); }
            set
            {
                setValue(value);
                expressionTree = null;
            }
        }

        /// <summary>
        /// Indicates if this expectation is blocking
        /// </summary>
        public bool Blocking
        {
            get { return getBlocking(); }
            set { setBlocking(value); }
        }

        /// <summary>
        /// When blocking, this indicates the deadling before the expectation should be achieved
        /// </summary>
        public double DeadLine
        {
            get { return getDeadLine(); }
            set { setDeadLine(value); }
        }

        /// <summary>
        /// The expectation expression
        /// </summary>
        public string Expression
        {
            get { return Value; }
            set { Value = value; }
        }

        public Interpreter.Expression expressionTree;
        public Interpreter.Expression ExpressionTree
        {
            get
            {
                if (expressionTree == null)
                {
                    expressionTree = EFSSystem.Parser.Expression(this, Expression);
                }
                return expressionTree;
            }
            set
            {
                expressionTree = value;
            }
        }

        public Interpreter.Expression conditionTree;
        public Interpreter.Expression ConditionTree
        {
            get
            {
                if (conditionTree == null && getCondition() != null)
                {
                    conditionTree = EFSSystem.Parser.Expression(this, getCondition());
                }
                return conditionTree;
            }
            set
            {
                conditionTree = value;
            }
        }

        public override string Name
        {
            get { return Expression; }
            set { }
        }

        public override System.Collections.ArrayList EnclosingCollection
        {
            get
            {
                System.Collections.ArrayList retVal = null;

                if (SubStep != null)
                {
                    retVal = SubStep.Expectations;
                }

                return retVal;
            }
        }

        /// <summary>
        /// Indicates the name of the checked variable, if any
        /// </summary>
        /// <returns></returns>
        public Interpreter.Designator CheckedVariable()
        {
            Interpreter.Designator retVal = null;

            Interpreter.BinaryExpression binaryExpression = ExpressionTree as Interpreter.BinaryExpression;
            if (binaryExpression != null)
            {
                Interpreter.UnaryExpression unaryExpression = binaryExpression.Left as Interpreter.UnaryExpression;
                if (unaryExpression != null && unaryExpression.Term != null && unaryExpression.Term.Designator != null)
                {
                    retVal = unaryExpression.Term.Designator;
                }
            }

            return retVal;
        }

        /// <summary>
        /// Adds a model element in this model element
        /// </summary>
        /// <param name="copy"></param>
        public override void AddModelElement(Utils.IModelElement element)
        {
        }

        /// <summary>
        /// Provides an explanation of the step's behaviour
        /// </summary>
        /// <param name="indentLevel">the number of white spaces to add at the beginning of each line</param>
        /// <returns></returns>
        public string getExplain(int indentLevel, bool explainSubElements)
        {
            string retVal = TextualExplainUtilities.Comment(this, indentLevel);

            if (Expression != null)
            {
                retVal += TextualExplainUtilities.Pad(Expression.ToString(), indentLevel);
            }

            return retVal;
        }

        /// <summary>
        /// Provides an explanation of the step's behaviour
        /// </summary>

        /// <param name="explainSubElements">Precises if we need to explain the sub elements (if any)</param>
        /// <returns></returns>
        public string getExplain(bool explainSubElements)
        {
            string retVal = "";

            retVal = getExplain(0, explainSubElements);

            return retVal;
        }
    }
}
