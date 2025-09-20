# Imagem base
FROM node:18

# Diretório de trabalho
WORKDIR /app

# Copia arquivos
COPY package*.json ./
RUN npm install

COPY . .

# Expõe a porta
EXPOSE 3000

# Comando de inicialização
CMD ["npm", "start"]