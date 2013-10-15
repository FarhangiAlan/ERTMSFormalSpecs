/*
* generated by Xtext
*/
package org.openetcs.dsl.parser.antlr;

import com.google.inject.Inject;

import org.eclipse.xtext.parser.antlr.XtextTokenStream;
import org.openetcs.dsl.services.ExpressionGrammarAccess;

public class ExpressionParser extends org.eclipse.xtext.parser.antlr.AbstractAntlrParser {
	
	@Inject
	private ExpressionGrammarAccess grammarAccess;
	
	@Override
	protected void setInitialHiddenTokens(XtextTokenStream tokenStream) {
		tokenStream.setInitialHiddenTokens("RULE_WS", "RULE_ML_COMMENT", "RULE_SL_COMMENT");
	}
	
	@Override
	protected org.openetcs.dsl.parser.antlr.internal.InternalExpressionParser createParser(XtextTokenStream stream) {
		return new org.openetcs.dsl.parser.antlr.internal.InternalExpressionParser(stream, getGrammarAccess());
	}
	
	@Override 
	protected String getDefaultRuleName() {
		return "Model";
	}
	
	public ExpressionGrammarAccess getGrammarAccess() {
		return this.grammarAccess;
	}
	
	public void setGrammarAccess(ExpressionGrammarAccess grammarAccess) {
		this.grammarAccess = grammarAccess;
	}
	
}