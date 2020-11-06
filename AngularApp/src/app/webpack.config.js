module.exports = {
    devServer: {
      headers:          { 'Access-Control-Allow-Origin': '*' },
      https:            false,
      disableHostCheck: true,
      public: 'localhost'
    }
  }