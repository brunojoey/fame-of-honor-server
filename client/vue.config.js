module.exports = {
  devServer: {
    disableHostCheck: true,
    port: 3000,
    public: '0.0.0.0:3000',
    proxy: {
      // wants to set /api/ = localhost only when in development
      '^/api': {
        target: "http://localhost:3000",
        changeOrigin: true,
        logLevel: 'debug',
        pathRewrite: { '^/api': '/'},
      },
    }
  }
}